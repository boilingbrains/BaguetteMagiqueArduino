
# __La baguette magique d'Harry Potter avec Arduino__

## Introduction: 
Ce projet consiste à réaliser une baguette magique qui peut reconnaître les sorts de l'univers Harry Potter grâce aux mouvements et le machine learning sur Arduino. 
J'ai utilisé les composants suivants:

* Baguette de fan Harry Potter
* Arduino Nano 33 BLE Sense
## Structure du projet
```
📦project
│   📜README.md
│   📜miniature.jpg
│   📜model.h
└───📂CodesArduino
│   │
│   └───📜IMU_Capture.ino
│   │
│   └───📜IMU_Classifier_Baguette.ino
│   │
│   └───📜IMU_Classifier_Baguette_v2.ino
│  
└───📂BaguetteMagiqueApp
    │
    └───📂.vs
    │   │  ...
    └───📂BaguetteMagique (C# code)
    │   │  ...
    └───📂Images
        │  ...
```
## Explications:
1. Collecte des données
   * Pour utiliser la centrale inertielle, il faut installer la bibliothèque "LSM9DS1" dans l'IDE Arduino

   * La collecte des données se fait avec le fichier IMU_Capture.ino
  
   * Le notebook Google Collab [ici](https://colab.research.google.com/github/arduino/ArduinoTensorFlowLiteTutorials/blob/master/GestureToEmoji/arduino_tinyml_workshop.ipynb)


2. Classification des données (nécessite model.h)

   * IMU_Classifier_Baguette.ino permet d'afficher le résultat sous forme de score de confiance
  
   * IMU_Classifier_Baguette_v2.ino affiche uniquement le nom du sort avec le plus grand score

3. Application Visual Studio

   * IMU_Classifier_Baguette_v2.ino doit être chargé sur la carte Arduino
     
   * Il faut modifier le chemin d'accès des images des sorts dans Form1.cs sur Visual Studio


<span style="display:block;text-align:center">

[![](miniature.jpg#center)](https://youtu.be/yDwRiH3Mfek)

</span>

    
