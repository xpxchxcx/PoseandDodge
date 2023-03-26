<img src="https://github.com/xpxchxcx/RGBD2Avatar/blob/main/PoseandDodge/pad.JPG">


<h4 align="center">
  <a href="https://github.com/xpxchxcx/RGBD2Avatar/blob/main/docs.md">Documentation</a>
</h4>

---

**Pose and Dodge** is an exciting game that leverages the power of a RGB-D camera to estimate the pose of the player and put it on a character mesh in the game. The objective of the game is to dodge obstacles while trying to survive for as long as possible.

The game uses a combination of real-time pose estimation and game physics to provide an immersive and challenging experience for the player. The obstacles are generated randomly, ensuring that each game is unique and presents a new challenge.


<p align="center">
 <img src=https://github.com/xpxchxcx/RGBD2Avatar/blob/main/PoseandDodge/padmove.gif alt="Sample Video 1"/>
</p>

## Usage

### Installation
1. We are using Azure Kinect as our RGBD Camera, download and install the necessary software [here](https://learn.microsoft.com/en-us/azure/kinect-dk/set-up-azure-kinect-dk). Do ensure the Azure Kinect Viewer and Body Tracking SDK is working before proceeding.

2. Download Unity version 2019.2.6 [here](https://unity.com/releases/editor/whats-new/2019.2.6).

3. Install git and git lfs before cloning the project.

4. If you run into any problems refer to Microsoft's Azure Kinect Unity [sample](https://github.com/microsoft/Azure-Kinect-Samples/blob/master/body-tracking-samples/sample_unity_bodytracking/README.md). You may also visit the video documentation on Azure Kinect Body Tracking Unity Integration [here](https://learn.microsoft.com/en-us/shows/mixed-reality/azure-kinect-body-tracking-unity-integration).


5. Clone this repository to access the source code.
```
git clone https://github.com/xpxchxcx/RGBD2Avatar.git
```
### Physical set-up

6. Prepare the physical environment. Some recommendations for setting up prior to deploying Microsoft's Azure Kinect Unity for Pose and Dodge include:

- Place the Kinect on a level surface at a suitable distance away from the user(s). Ideally, the player should be able to have enough space to move around in the game space with **full body of the user visible**.
- Have sufficient lighing, if possible.
- The body of the player should face the camera directly at all times, if possible. Avoid turning to the side as this will mess with the detection algorithm.

### Deployment

7. Navigate to the unity project and build the game.


The game will start with a home screen and then character selection screen.

The game will then require you to calibrate and ensure the Kinect Azure is able to detect you. Once you're ready click the Initiate Wave Button.

When your health reaches 0 the games ends. You are required to hard-reset the application due to errors reinitialising and disposing of the Kinect Body tracker.

## Acknowledgements

We would like to thank the following organizations for their contributions to this project:

Microsoft for creating the Azure Kinect camera and providing the Body Tracking SDK that we used in our game.

The developers of the Unity game engine, which we used to create the game.






