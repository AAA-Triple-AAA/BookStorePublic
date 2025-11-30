using BookStoreDO.DataAccessClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreUI
{
    public partial class frmSalesReport : Form
    {
        private readonly BookStoreDataAccess _data = new();

        public frmSalesReport()
        {
            InitializeComponent();
        }

        public List<SalesReportItemDTO> GetSalesReport(DateTime start, DateTime end)
            => _data.GetReports(start, end);

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var start = dtpStartDate.Value.Date;
            var end = dtpEndDate.Value.Date;

            var salesItems = GetSalesReport(start, end);

            dgvSales.DataSource = salesItems;

            var total = salesItems.Sum(s => s.TotalValue);
            txtTotalValue.Text = total.ToString("C");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show(@"There is no data to export.", @"Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "SalesReport.csv",
                Title = "Export Sales Report"
            };

            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                var sb = new StringBuilder();

                // Build header row from visible columns
                var columns = dgvSales.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(c => c.Visible)
                    .OrderBy(c => c.DisplayIndex)
                    .ToList();

                sb.AppendLine(string.Join(",", columns.Select(h => EscapeForCsv(h.HeaderText))));

                // Build data rows
                foreach (DataGridViewRow row in dgvSales.Rows)
                {
                    if (row.IsNewRow) continue;

                    var values = new List<string>();

                    foreach (var col in columns)
                    {
                        var value = row.Cells[col.Index].Value;
                        if (value == null)
                        {
                            values.Add(string.Empty);
                            continue;
                        }

                        // Format known types nicely
                        switch (value)
                        {
                            case DateTime dt:
                                values.Add(EscapeForCsv(dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)));
                                break;
                            case decimal dec:
                                values.Add(EscapeForCsv(dec.ToString("F2", CultureInfo.InvariantCulture)));
                                break;
                            case double d:
                                values.Add(EscapeForCsv(d.ToString("G", CultureInfo.InvariantCulture)));
                                break;
                            case float f:
                                values.Add(EscapeForCsv(f.ToString("G", CultureInfo.InvariantCulture)));
                                break;
                            case int i:
                                values.Add(EscapeForCsv(i.ToString(CultureInfo.InvariantCulture)));
                                break;
                            default:
                                values.Add(EscapeForCsv(Convert.ToString(value, CultureInfo.InvariantCulture) ?? string.Empty));
                                break;
                        }
                    }

                    sb.AppendLine(string.Join(",", values));
                }

                // Write UTF8 with BOM for Excel compatibility
                File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

                MessageBox.Show($"Exported {dgvSales.Rows.Count} rows to:\n{dlg.FileName}", @"Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Export failed:\n{ex.Message}", @"Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeForCsv(string s)
        {
            if (s == null)
                return string.Empty;

            // If string contains quote, comma, or newline, wrap in quotes and escape quotes by doubling them.
            var needsQuotes = s.Contains(',') || s.Contains('"') || s.Contains('\n') || s.Contains('\r');

            if (!needsQuotes) return s;
            var escaped = s.Replace("\"", "\"\"");
            return $"\"{escaped}\"";

        }
    }
}
