Batteries 1-9

Two Values

Go through sequence and find the first largest digit,
Go through sequence again begining at the largest digit and get the second largest digit

---

12 Values, Need a more general solution

Find Largest digit, Ignoring the last 11 digits
Find next largest digit and loop 11 times
--------------------------------------------X-X-X-X-X-X-X-X-X-X-X
7-6-5-4-3-2-3-4-5-6-7-8-9-8-7-6-5-4-3-2-3-4-5-6-5-6-6-4-4-5-5-4-6
7-7-7-7-7-7-7-7-7-7-7-8-9-9-9-9-9-9-9-9-9-9-X-X-X-X-X-X-X-X-X-X-X
--------------------------8-8-8-8-8-8-8-8-8-8-X-X-X-X-X-X-X-X-X-X
----------------------------7-7-7-7-7-7-7-7-7-7-X-X-X-X-X-X-X-X-X
------------------------------6-6-6-6-6-6-6-6-6-6-X-X-X-X-X-X-X-X
--------------------------------5-5-5-5-5-5-5-6-6-6-X-X-X-X-X-X-X
------------------------------------------------5-6-6-X-X-X-X-X-X
----------------------------------------------------6-6-X-X-X-X-X
------------------------------------------------------4-4-X-X-X-X
--------------------------------------------------------4-5-X-X-X
------------------------------------------------------------5-X-X
--------------------------------------------------------------4-X
----------------------------------------------------------------6
------------------------9-8-7-6-5-X-X-X-X-X-X-X-X-6-6-4-4-X-5-4-6
------------------------------------------9-8-7-6-5-6-6-4-4-5-6-6

Check for largest digit from LastIndex to Length-11
Check for largest digit from LastIndex to Length-10
Check for largest digit from LastIndex to Length-9
Check for largest digit from LastIndex to Length-8
Check for largest digit from LastIndex to Length-7
Check for largest digit from LastIndex to Length-6
Check for largest digit from LastIndex to Length-5
Check for largest digit from LastIndex to Length-4
Check for largest digit from LastIndex to Length-3
Check for largest digit from LastIndex to Length-2
Check for largest digit from LastIndex to Length-1

Method that takes a list and a range

9-8-7-6-5-4-3-2-1-1-1-1-1-1-1
9-8-7-6-X-X-X-X-X-X-X-X-X-X-X -> 9,0
X-8-7-6-5-X-X-X-X-X-X-X-X-X-X -> 8,1
X-X-7-6-5-4-X-X-X-X-X-X-X-X-X -> 7,2
X-X-X-6-5-4-3-X-X-X-X-X-X-X-X -> 6,3
X-X-X-X-5-4-3-2-X-X-X-X-X-X-X -> 5,4
X-X-X-X-X-4-3-2-1-X-X-X-X-X-X -> 4,5
X-X-X-X-X-X-3-2-1-1-X-X-X-X-X -> 3,6
X-X-X-X-X-X-X-2-1-1-1-X-X-X-X -> 2,7
X-X-X-X-X-X-X-X-1-1-1-1-X-X-X -> 1,8
X-X-X-X-X-X-X-X-X-1-1-1-1-X-X -> 1,9
X-X-X-X-X-X-X-X-X-X-1-1-1-1-X -> 1,10
X-X-X-X-X-X-X-X-X-X-X-1-1-1-1 -> 1,11
987654321111

818181911112111
8181XXXXXXXXXXX -> 8,0
X1818XXXXXXXXXX -> 8,2
XXX181XXXXXXXXX -> 8,4
XXXXX19XXXXXXXX -> 9,6
XXXXXXX1XXXXXXX -> 1,7
XXXXXXXX1XXXXXX -> 1,8
XXXXXXXXX1XXXXX -> 1,9
XXXXXXXXXX1XXXX -> 1,10
XXXXXXXXXXX2XXX -> 2,11
XXXXXXXXXXXX1XX -> 1,12
XXXXXXXXXXXXX1X -> 1,13
XXXXXXXXXXXXXX1 -> 1,14
