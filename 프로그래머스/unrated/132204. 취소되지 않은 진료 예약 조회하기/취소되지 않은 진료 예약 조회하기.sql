SELECT APNT_NO, PT_NAME, AP.PT_NO, AP.MCDP_CD, DR_NAME, APNT_YMD
FROM APPOINTMENT AP
    JOIN PATIENT P ON P.PT_NO = AP.PT_NO
    JOIN DOCTOR D ON AP.MDDR_ID = D.DR_ID

WHERE APNT_CNCL_YN = 'N' AND DATE(APNT_YMD) = '2022-04-13'

ORDER BY APNT_YMD ASC