SELECT SUBSTR(T.PRODUCT_CODE, 1, 2) AS CATEGORY, COUNT(T.PRODUCT_CODE) AS PRODUCTS
FROM PRODUCT T
GROUP BY CATEGORY
ORDER BY CATEGORY ASC