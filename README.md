# MegaPrimeFinder
                                  Design Approach 

Activity Diagram

![image](https://user-images.githubusercontent.com/42170562/229465825-cdf42db0-e92b-4bc1-8cbc-11137a6c66e2.png)


 

•	Initially it will check whether the max is 0 or 1 and return the empty list.

•	If not it will add 2 to the list 
  o	Reason –  Since we know that the 2 is mega prime and then the loop can be started with i = 3 and increment with 2 (i += 2) since we know that even numbers cannot be a prime and only can go through the odd numbers.

•	CheckDigits method – It will check whether the individual digits are prime or not. If it’s true  it will execute the IsPrime method.

•	IsPrime method – It will check whether the given integer is prime or not.

•	Reason for first CheckDigit() and then IsPrime() => IsPrime() will go through more cycles comparing with CheckDigit(). From making CheckDigit() as the first condition, we can ignore a lot of non mega prime numbers (which are prime) without going through IsPrime method. (Ex: 13,19, 29,67, all the prime numbers which contains 1, all prime numbers which contains even digits)

•	If both conditions are satisfied i will be added to the list.

•	This loop will continue until i is equals to max and return the list.

  
  Other Options
1.	First check IsPrime() and then CheckDigit() 
Reasons for not selected
•	 IsPrime() will go through more cycles comparing with CheckDigit(). From making CheckDigit() as the first condition, we can ignore a lot of non mega prime numbers (which are prime) without going through IsPrime method. (Ex: 13,19, 29,67, all the prime numbers which contains 1, all prime numbers which contains even digits)
•	And also if we check IsPrime() first, it will check IsPrime for all the odd numbers (since i is incremented by 2) which is unnecessary and time consuming. So performance wise it will be a disadvantage. 

2.	We should have incremented i with 1 instead of 2 (i++) – Since we already know that even number cannot be a prime number, no point of checking all.


  
  IsPrime() Method
  
•	double dblSqrt = Math.Sqrt(n); - This is used to get the square root of n. Then we don’t need to go beyond that number to check whether the number is prime.             
Ex : if n = 277  => double dblSqrt = 16.64 
       With Math.Floor(dblSqrt), it will become 16. So no point of going beyond 16 to check whether 277 has devisors. So we can end the loop in when i=16. 

•	Loop increment with 2. (i += 2) - Since we already know that even number cannot be a prime number, no point of checking all.


  CheckDigits() Method

•	Went with the approach with checking the remainder by dividing by 10 in the loop.
o	Other options – It can be done by converting the given integer to string and split it to char array. Then convert char to int and same conditions can be applied as here to individual digits. (if(digit != 2 && digit != 3 && digit != 5 && digit != 7) – but this approach takes more processing power comparing with the one that’s been implemented. 
(dividing by 10 in the loop)



