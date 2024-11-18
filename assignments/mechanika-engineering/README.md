# Mechanika Engineering

Test data archive contains following files:

- `camera_intrinsics.json` - camera intrinsics parameters
- `png_image.png` - target image in png format
- `raw_image.npy` - target image as npy array

During image capture a camera was positioned in a way, so the camera image plane is parallel to the wall. Distance between the camera and the wall equals 380mm.

Write a code in `Python` (using `OpenCV` and `Numpy` libraries) which will process given image and output following data:

- Amount of figures in scene;
- Name of the figures shape;
- Get measurements in mm:
  - Length of rectangle side
  - Circle radius
  - Value of any triangle angle
