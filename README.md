# Flying_Bird_Game

Project Language and Tools:

This project was made in Microsoft Visual Studio 2019 and the language used to make this application is C# which is the advance version of C++.


Working of the game application:

1- At first we choose WINDOWS FORM APP (.NET FRAMEWORK).
2- Then we adjust the form according to our need.
3- After that we import pictures that we need to implement according to our game which include two pole obstacle and a bird and a ground once that is imported we adjust them accordingly.
We also create labels for score, restart and quit, which we implement later.
4- After adjusting we move on to the programing side at first we need three variables speed of the obstacle, its gravity speed, and default score.
5- After that is done we move towards the keys we link the key we are going to use with the form. We all set two methods KEYUP and KEYDOWN which tells us that the space key is pressed or released.
6- Then we will try to move obstacle towards the left (top, bottom) we use if statement and set a condition of its location and score as they move towards left, and also we use another if statement to increase the obstacle speed after you score a specific point in this case after you score 10 points, then we also create a condition for ending a game which includes touching the obstacle or hitting the ground and also flying outside of the screen.
7- During this we create a method called ENDGAME that tells the program what to do after the game ends.
8- When the game ends a MENU box appears which tells you the game is over and gives you two options whether you want to restart or quit the game. So we create two more methods RESTART, QUIT.
9- In RESTART METHOD we tell the application to set the timer and the bird and obstacle to the default position including score.
10- In QUIT method we tell the application to shut down.



 ![Screenshot (2)](https://user-images.githubusercontent.com/71840877/130745124-3c864969-3800-4c15-a9bf-bd57bf22767e.png)
