#### Question 1: Dynamic Programming
A quality agent is responsible for inspecting samples of the finished products in the production line. Each sample contains defective and non-defective products represented by 1 and 0 respectively. The product samples are placed sequentially in a two dimensional square matrix. The goal is to determine the size of the largest square of defective products in the two-dimensional square matrix.

##### Example
n x n = 5 x 5 matrix of product samples
samples = [[1, 1, 1, 1, 1], [1, 1, 1,0,0], [1, 1, 1,0,0], [1, 1, 1,0,0], [1, 1, 1, 1]]

- The first square of defective products is a sub-matrix 3x 3 starting at (0,0) and ending at (3,3)
- The second square of defective products is also a sub-matrix 3 x 3 scarang actuo and ending at (4,3)
- The third square of defective products is also a sub-matrix 3 x 3 starting at (2,0) and ending at (5,3)
- The size of the argest square of defective products is

##### Function Description
Complete the function findLargestSquareSize in the editor below.

findLargestSquareSize has the following parameter:
    int samples[n][n]: a two-dimensional array of integers

##### Returns:
    int an integer that represents the size of the largest square sub-matrix of defective products.

##### Constraints
- 05 ≤ 500
- samples ones in the set so, To denotes anon-derectve products and y denotes a defecave product

##### Input Format For Custom Testing
###### Sample Case O


Sample Input For custom Testing

STDIN            FUNCTION
   3     ->  samples size n = 3
   3     ->  samples i size n = 3
   1 1 1 ->  samples = [[1,1,1], [1,1,0],[1,0,1]]
   1 1 0
   1 0 1

Sample Output:
2



#### Question 2:
A bank wants to know how many transactions were made by each of their customers in the years 2019, 2020, and 2021. The first two characters of the transaction id in the table transactions represent the year the transaction was made. For example, transaction id 20345 would have been made in 2020. Write an SQL query that returns all the users and the number of transactions made by them in years 2019, 2020, and 2021 in different columns.

Note: The dataset also contains transactions from years other.

Table definitions and a data sample are given below:

Users
| Field    | Type    |
|----------|---------|
| user_id  |integer  |
| user_name| string  |

Transactions
| Field    | Type    |
|----------|---------|
| tran_id  |integer  |
| User_id  | string  |

#### Sample Data

##### Users

|user_id	| user_name |
|----------|---------|
|248 |	Stokes|
|448 |	Francis|
|638 |	Hunter|
|701 |	Hanson|
|984 |	Martin |

##### Transactions

|transaction_id	|user_id|
|----------|---------|
|19910	|448|
|19685	|701|
|21890	|701|
|17679	|248|
|20697	|701|
|19568	|701|
|20573	|701|
|17464	|701|
|19492	|248|
|20541	|701|
|20307	|248|

Solution:

```SQL
SELECT
    u.user_name,
    COUNT(CASE WHEN LEFT(t.tran_id, 2) = '19' THEN 1 END) AS Transactions_2019,
    COUNT(CASE WHEN LEFT(t.tran_id, 2) = '20' THEN 1 END) AS Transactions_2020,
    COUNT(CASE WHEN LEFT(t.tran_id, 2) = '21' THEN 1 END) AS Transactions_2021
FROM
    Users u
LEFT JOIN
    Transactions t
ON
    u.User_Id = t.User_id
GROUP BY
    u.User_Id, u.user_name
ORDER BY
    u.User_Id;

```
RESULT:

|user_name |	Transactions_2019 |Transactions_2020 |	Transactions_2021|
|----------|---------|----------|---------|
|Stokes|	4|	3|	2|
|Francis|	1|	1|	1|
|Hunter|	1|	2|	3|
|Hanson|	5|	4|	1|
|Martin|	2|	1|	3|

#### Question 3: RegistrationAPI
https://github.com/ekumachidi/HackerRank-RegistrationAPI