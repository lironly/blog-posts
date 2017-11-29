CREATE PROCEDURE [Media].[usp_Media_Video_GetAll]
AS
BEGIN
	SELECT   v.VideoId
			,v.VideoName
	FROM [Media].[Video] AS v
END
GO