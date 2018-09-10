<h1>INACTIVITY PREVENTER</h1>

<b>Created by:</b> Kacper Stachowski (k.stachowski92@gmail.com)</br>
<b>Art by:</b> Kaja Kosmala (thekoskaya@gmail.com)</br>
<b>Exe downloaded from:</b> https://github.com/KacperStachowski/Inactivity-Preventer-Exe</br>
<b>Code can be found at:</b> https://github.com/KacperStachowski/Inactivity-Preventer


Inactivity Preventer is a simple desktop application that prevents PC and Skype from going into inactive state when you can't change system settings manually.

It moves a mouse pointer for a number of times randomly picked from a range selected by the user in interval selected from range of 5 to 300 seconds. Each action can also be configured to write some text per each mouse move.


<h2>PROPERTIES:</h2>

<h3>Actions per loop: [X] - [Y] </h3>
Defines a range of numbers from which a random number of actions to be performed will be picked. New, random number of actions is picked from the same range after each loop is finished.

* <b>[X]</b> - Defines a starting number of range. Minimum value is 5, maximum is 98. The value will be set to minimum value automatically if an user inputs a non-numeric value or value lower than 5. The number will be set to maximum value if an user inputs value higher than 98.

* <b>[Y]</b> - Defines an ending number of range. Minimum value is [X] + 1, maximum is 99. The number will be set to minimum value automatically if an user inputs a non-numeric value or value lower than [X].


<h3>Interval: [Z] seconds</h3>

* <b>[Z]</b> - Defines a time that has to pass between each actions set to be performed. Mimimum value is 5, maximum value is 300. The value will be set to minimum value automatically if an user inputs a non-numeric value or value lower than 5. The number will be set to maximum value if an user inputs value higher than 300.

<h3>Use keyboar while performing action</h4>

* Defines if each action in an actions set will also consist of inputting a text from <b>[Text written per action:]</b> textbox. If this checkbox is selected, a text will be typed automatically after each mouse move while performing action, as many times as actions number selected from <b>[Actions per loop:]</b> range.

<h3>TIP</h3>
While Inactivity Preventer is working, it will type text to a currently active window, meaning that if an user starts the application and clicks on something else like notepad or a website, the application will type text into the currently active window. Remember to focus Inactivity Preventer window when you are not working on your PC. 

<h3>TIP</h3>
In some cases using keyboard while performing actions will be required to keep your PC and Skype from going inactive.
