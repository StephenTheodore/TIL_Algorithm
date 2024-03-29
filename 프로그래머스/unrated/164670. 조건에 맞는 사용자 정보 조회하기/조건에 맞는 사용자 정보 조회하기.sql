SELECT
    USER_ID,
    NICKNAME,
    CONCAT_WS(' ', CITY, STREET_ADDRESS1, STREET_ADDRESS2) AS '전체주소',
    CONCAT_WS('-', SUBSTRING(TLNO, 1, 3), SUBSTRING(TLNO, 4, 4), SUBSTRING(TLNO, 8, 4)) AS '전화번호'

FROM USED_GOODS_BOARD B JOIN USED_GOODS_USER U ON B.WRITER_ID = U.USER_ID

GROUP BY WRITER_ID
HAVING COUNT(WRITER_ID) >= 3

ORDER BY USER_ID DESC