/*
◆ 문제 설명
1. ANIMAL_INS 테이블은 동물 보호소에 들어온 동물의 정보를 담은 테이블입니다.

ANIMAL_INS 테이블 구조는 다음과 같습니다.
ANIMAL_ID, ANIMAL_TYPE, DATETIME, INTAKE_CONDITION, NAME, SEX_UPON_INTAKE
동물의 아이디, 생물 종, 보호 시작일, 보호 시작 시 상태, 이름, 성별 및 중성화 여부를 나타냅니다.

NAME	            TYPE	    NULLABLE
ANIMAL_ID	        VARCHAR(N)	FALSE
ANIMAL_TYPE	        VARCHAR(N)	FALSE
DATETIME	        DATETIME	FALSE
INTAKE_CONDITION	VARCHAR(N)	FALSE
NAME	            VARCHAR(N)	TRUE
SEX_UPON_INTAKE	    VARCHAR(N)	FALSE

2. ANIMAL_OUTS 테이블은 동물 보호소에서 입양 보낸 동물의 정보를 담은 테이블입니다.

ANIMAL_OUTS 테이블 구조는 다음과 같습니다.
ANIMAL_ID, ANIMAL_TYPE, DATETIME, NAME, SEX_UPON_OUTCOME
동물의 아이디, 생물 종, 입양일, 이름, 성별 및 중성화 여부를 나타냅니다.
ANIMAL_OUTS 테이블의 ANIMAL_ID는 ANIMAL_INS의 ANIMAL_ID의 외래 키입니다.

NAME	            TYPE	    NULLABLE
ANIMAL_ID	        VARCHAR(N)	FALSE
ANIMAL_TYPE	        VARCHAR(N)	FALSE
DATETIME	        DATETIME	FALSE
NAME	            VARCHAR(N)	TRUE
SEX_UPON_OUTCOME	VARCHAR(N)	FALSE


보호소에서 중성화 수술을 거친 동물 정보를 알아보려 합니다.
보호소에 들어올 당시에는 중성화되지 않았지만, 보호소를 나갈 당시에는 중성화된 동물의 아이디와 생물 종, 이름을 조회하는 아이디 순으로 조회하는 SQL 문을 작성해주세요.

◆ 예시
ANIMAL_INS 테이블과 ANIMAL_OUTS 테이블이 다음과 같다면

1. ANIMAL_INS
ANIMAL_ID	ANIMAL_TYPE     DATETIME	            INTAKE_CONDITION	NAME	    SEX_UPON_INTAKE
A367438 	Dog       	    2015-09-10 16:01:00 	Normal	            Cookie	    Spayed Female
A382192 	Dog      	    2015-03-13 13:14:00 	Normal      	    Maxwell2	Intact Male
A405494 	Dog      	    2014-05-16 14:17:00 	Normal      	    Kaila	    Spayed Female
A410330 	Dog      	    2016-09-11 14:09:00 	Sick        	    Chewy	    Intact Female

2. ANIMAL_OUTS
ANIMAL_ID	ANIMAL_TYPE	DATETIME	            NAME	    SEX_UPON_OUTCOME
A367438 	Dog     	2015-09-12 13:30:00	    Cookie	    Spayed Female
A382192 	Dog     	2015-03-16 13:46:00	    Maxwell2	Neutered Male
A405494 	Dog     	2014-05-20 11:44:00	    Kaila   	Spayed Female
A410330 	Dog     	2016-09-13 13:46:00	    Chewy   	Spayed Female

Cookie는 보호소에 들어올 당시에 이미 중성화되어있었습니다.
Maxwell2는 보호소에 들어온 후 중성화되었습니다.
Kaila는 보호소에 들어올 당시에 이미 중성화되어있었습니다.
Chewy는 보호소에 들어온 후 중성화되었습니다.

따라서 SQL문을 실행하면 다음과 같이 나와야 합니다.
ANIMAL_ID	ANIMAL_TYPE	NAME
A382192 	Dog     	Maxwell2
A410330 	Dog     	Chewy
*/

SELECT O.ANIMAL_ID, O.ANIMAL_TYPE, O.NAME
FROM ANIMAL_OUTS O
LEFT JOIN ANIMAL_INS I USING(ANIMAL_ID)

WHERE O.SEX_UPON_OUTCOME != I.SEX_UPON_INTAKE

ORDER BY O.ANIMAL_ID