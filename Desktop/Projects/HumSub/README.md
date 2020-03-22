# HumSub

Instructions on downloading our code:
1.	Before starting, one must have all the right tools. Make sure one has Microsoft Visual Studio 2019 and the Xamarin Tool in the environment. 
2. 	Open Microsoft Visual Studio, on the top toolbar, go to Tools -> Android -> Android SDK Manager 
3. 	Click and install Android SDK Oreo 8.1
4. 	After, go back to Microsoft Visual Studio, on the top toolbar, go to Tools -> Android -> Android Device Manager 
5.	Create a new, and select device (Ours was Nexus 5 because of higher performance). This is how the emulator runs in xamarin. 
6. Now grab and copy the project from our github repository. 
7. Open the project on github and run the project using the Nexus 5 emulator.  

Instructions on the Application: 
1. To begin, our app provides a screen that shows a photo that represents the company HumSub. The photo is HumSub written in Urdu Scripture, which translates to “We all”, meaning we treat the world as one big family. In order to execute, we source the picture through the internet as the image address location. 

2.We call the front page the main page as the user is shown two buttons. The user has an option to click two buttons: one that is labeled “Login As User”, and the other labeled as “Login As Guest”. Both buttons have the functionality of being clickable and contain functions in response. 

3.The login as user takes the user into a different page named “Login Page”. In this pathway, there are two entry boxes, one for Username/Email and the other for the password. As a test case, we made sure the password is unreadable on the screen because of privacy concerns. On the left corner, there’s a toolbar that allows the users to go back to the MainPage if clicked accidentally. We can still see the same image from the MainPage. Now near the bottom, there’s two buttons of Sign In and forgot password. As of the first iteration, we haven’t yet introduced the database therefore not yet added functionality to those two buttons. 

4. If the User decides to click on “Login As Guest”, the application will directly access the Main App Page. 

5. The HumSub image is still showing and now the user is given a white title on the toolbar HumSub. There’s a picker below the picture to let the user pick the type of category for articles.  

