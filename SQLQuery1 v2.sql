-- Rename PubId -> pub_id
EXEC sp_rename 'dbo.Publishers.PubId', 'pub_id', 'COLUMN';

-- Rename PubName -> pub_name
EXEC sp_rename 'dbo.Publishers.PubName', 'pub_name', 'COLUMN';
