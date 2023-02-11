SELECT DISTINCT CR.CAR_ID 

FROM CAR_RENTAL_COMPANY_CAR CR
JOIN CAR_RENTAL_COMPANY_RENTAL_HISTORY CH
ON CR.CAR_ID = CH.CAR_ID

WHERE CR.CAR_TYPE = '세단' AND DATE_FORMAT(CH.START_DATE, '%Y-%m') = '2022-10'

ORDER BY CR.CAR_ID DESC