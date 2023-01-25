# Game Scripts

## TrackerHandler.cs
- This script is responsible for handling the Azure Kinect body tracking data and mapping the joints to the corresponding bones in the character model.
- It creates a dictionary that maps the parent joint for each joint in the body
- It also creates a quaternion array to store the absolute joint rotations
- It also contains a boolean variable that determines whether to draw the skeletons or not.
- It creates a Quaternion Y_180_FLIP to flip the180 degree rotation of the joints
- It contains a function Awake() that sets the parent joint map for all the joints in the body
- It also sets the basis joint map to align the joints with the character model
- It has a function called Update() that is responsible for updating the joint rotations, parent joint rotations and the absolute joint rotations.
- It also handles the skeleton drawing when the drawSkeletons variable is set to true.

---

## PuppetAvatar.cs
- Maps the movement of a player captured by an Azure Kinect sensor to a 3D character in a Unity game
- Maps the joints of the player to the corresponding bones of the character
- Uses the data captured by the sensor to animate the character
- Uses an Animator component to control the animation of the character
- Uses a dictionary to store the offset of each joint
- Imports classes from UnityEngine and Microsoft.Azure.Kinect.BodyTracking libraries
- Maps the JointIds of the player to the corresponding bones of the character using the function MapKinectJoint
- Position the character based on the sensor data using the mapping
- Uses GameObject.Find() to find the objects in the scene
- Initialize variables and get necessary components in the Awake() and Start() functions
- Overall script is used to control the animation of the 3D character based on the movement of the player captured by the Azure Kinect sensor.

---

## ChangeScene.cs

- Script that controls the functionality of changing scenes in a Unity game.
- The LoadScene function takes a string variable sceneName as an input and loads the corresponding scene. If the input is "Quit", the function will close the application.
- The Quit() function is used to close the application.
- The LoadGame() function is used to load a specific scene, in this case, the scene with index 1.
- Overall this script is used to change scenes in the game and to provide button functionality for the player to go to different parts of the game or to quit the game.

---

## DetectObstacle.cs

- Keeps track of the player's health and updates the health bar accordingly
- Detects when the player collides with an obstacle and subtracts health
- Ends the game if health reaches 0 or the player goes out of bounds
- Plays a sound and flashes the screen when the player takes damage
- Has a 2-second cooldown for taking damage
- Allows player to test damage by pressing the spacebar
- Has a background audio that plays on awake
- uses a GameObject called getHitScreen to flash the screen
- uses AudioSource for hurtAudio and backgroundAudio
- uses a GameObject called target to reference the player object
- uses a HealthBar script to manage health bar
- uses a GameManager script to end the game
- Two float variables called outBoundsOne and outBoundsTwo that determine the out of bounds zone for the player

---

## DeployObstacles.cs

- Script that controls the spawning and movement of obstacles in a Unity game
- Declares private variables for a Rigidbody, Vector3 position, and a random number
- Declares a public list of GameObject for obstacles and a public float variable speed to control the speed of obstacles movement
- Declares a private variable obstaclePrefab to hold the current obstacle GameObject.
- Declares a public float variable respawnTime to control the time between obstacle spawns
- The spawnObstacle function is called to randomly select an obstacle from the list of obstacles and instantiate it at the start position with a Rigidbody component
- The obstacleWave function is a coroutine that waits for a certain amount of time (respawnTime) and then calls the spawnObstacle function
- The script starts the coroutine in the Start() function to begin spawning obstacles
- Overall this script is used to control the spawning and movement of obstacles in the game.

---

## Score.cs

- Script that displays the current score during the game
- Declares a public variable for a Text object to display the score
- In the Update() function, the script sets the scoreText.text to the current value of ObjectHandler.scoreCounter converted to a string with "0" as the format
- This script is used to display the current score of the game on the screen and updates the score in real-time as the game progresses.

---

## FinalScore.cs

- Script that displays the final score at the end of the game
- Declares a public variable for a Text object to display the score
- Declares a private variable storeText to store the score as a string
- In the Update() function, the script sets the value of storeText to the current value of ObjectHandler.scoreCounter converted to a string with "0" as the format
- The finalScoreText.text is set to the value of storeText to display the current score on the text object
- This script is used to display the final score of the game on the screen

---

## HealthBar.cs

- Script that controls the functionality of the health bar in a Unity game
- Declares public variables for a Slider, Gradient, and Image object
- The SetMaxHealth function is called to set the maximum value of the health bar and to initialize the fill color
- The SetHealth function is called to update the current value of the health bar and to update the fill color to match the gradient object's color at the current normalized value of the slider
- The fill color of the health bar is determined by the gradient.Evaluate(slider.normalizedValue) which gives the color at the current normalize value of the health bar
- Overall this script is used to update and display the health status of a character or object in the game

---

## ChildCollider.cs

- Detects collisions between the child object of a parent object and an obstacle
- When a collision is detected, the script checks if the detectObstacle object can currently take damage
- If it can, the script calls the damageScreen() function and plays a hurt sound
- Decrements the currentHealth variable and updates the health bar
- If the currentHealth reaches 0, the script calls the EndGame() function on the GameManager object
- Sets the canTakeDamage variable to false and starts a cooldown period before the object can take damage again

---

## GameManager.cs

- Manages the game over functionality in the scene
- Declares a static variable gameHasEnded to keep track if the game has ended or not
- Declares a variable restartDelay to set a delay before the scene restarts
- Declares a variable gameOverUI to hold the game over UI object
- The EndGame() function is called when the game is over
- Checks if the game has ended, if not it sets the gameHasEnded variable to true and logs "GAME OVER" 
- Calls the GameOverScreen() and Invoke() function to call the Restart() function after the delay specified in the restartDelay variable.
- The Restart() function is used to reload the current scene, effectively restarting the game.
