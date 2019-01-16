CREATE PROCEDURE [dbo].sp_CheckPaymentIDExists
	@paymentID  varchar(5)
	AS
	SELECT count(0) FROM PROGPAYMENT
	WHERE PMTID=@paymentID
RETURN 0
