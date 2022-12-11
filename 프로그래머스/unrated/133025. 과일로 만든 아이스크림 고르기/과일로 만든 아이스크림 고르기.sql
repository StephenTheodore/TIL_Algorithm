SELECT H.FLAVOR
FROM FIRST_HALF H JOIN ICECREAM_INFO I ON H.FLAVOR = I.FLAVOR
WHERE INGREDIENT_TYPE = 'fruit_based' AND TOTAL_ORDER > 3000