BEGIN TRY
BEGIN TRANSACTION

	DECLARE @ProductTypeID as int
	DECLARE @ProductTypeCode as nvarchar(50)
	DECLARE @ProductTypeName as nvarchar(MAX)

	DECLARE cursorProductType CURSOR  FOR
		SELECT DISTINCT ProductTypeID, ProductTypeCode, ProductTypeName
		FROM ProductTypeSrc

	OPEN cursorProductType	  
	FETCH NEXT FROM cursorProductType INTO @ProductTypeID, @ProductTypeCode, @ProductTypeName
	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		
		INSERT INTO ProductTypeDst(ProductTypeCode, ProductTypeName)
		    VALUES(cast(@ProductTypeCode as int) + 1000, @ProductTypeName + N' - sopy to DST')

		UPDATE ProductTypeSrc SET ProductTypeProcessed = Getdate() WHERE ProductTypeID = @ProductTypeID

		FETCH NEXT FROM cursorProductType INTO @ProductTypeID, @ProductTypeCode, @ProductTypeName
	END   
	CLOSE cursorProductType;  
	DEALLOCATE cursorProductType;  
	
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	IF (@@TRANCOUNT > 0)         
		ROLLBACK TRANSACTION

	DECLARE @error nvarchar(1024)
	SET @error = N'ERROR: ' + ERROR_MESSAGE() + N' (while data copy)'
	RAISERROR (@error, 11, 1)
END CATCH
