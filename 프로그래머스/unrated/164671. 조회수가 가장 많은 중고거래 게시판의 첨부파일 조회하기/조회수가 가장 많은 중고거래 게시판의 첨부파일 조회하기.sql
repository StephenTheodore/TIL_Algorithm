SELECT
    CONCAT('/home/grep/src/', UGF.BOARD_ID, '/', UGF.FILE_ID, UGF.FILE_NAME, UGF.FILE_EXT) AS 'FILE_PATH'
    
FROM USED_GOODS_FILE UGF
    JOIN (
        SELECT *
        FROM USED_GOODS_BOARD
        ORDER BY VIEWS DESC
        LIMIT 1
    ) UGB ON UGB.BOARD_ID = UGF.BOARD_ID
    
ORDER BY UGF.FILE_ID DESC