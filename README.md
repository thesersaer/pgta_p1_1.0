# Asterix Decoder
The Asterix Decoder is a program for windows, developed with C#, that allows you to decode an Asterix file into category 10 (SMR and MLAT) and category 21 (ADS-B) messages of the eurocontrol Asterix system.


## How it works?
The program allows you to load .ast files. Then, the program will decode the information and you will be able to see the main data in a table. Clicking on the data item that you want in the table, you will be able to see the rest of the information on the same window. Also you can search in this table.


You can also see the decoded information loaded on a map. On the map you can see the vehicles, see the main information of each one by clicking on it, view the history of vehicle positions, change the map view, change the velocity of the simulation, select which category do you want to see and change the initial hour.

## ScreenShots

### Introduction of the program/MAIN page

![Captura de pantalla 2022-12-07 095053](https://user-images.githubusercontent.com/114604246/206151868-7c548118-9a8d-425a-bffc-3692d03a3b0c.jpg)

This is the first thing that you will see when you open the program. Here you can access to the Help page, you can upload the Asterix file to decode it, and then you can access to the table page and the map page. If you do not upload an Asterix file, the program will not allow you to access the map and table pages.

### Help page

![Captura de pantalla 2022-12-07 110725](https://user-images.githubusercontent.com/114604246/206152823-7d424668-a890-43b1-91f4-bebcbca001b9.jpg)

Here, you will find all the information you need to make the program work correctly.

### Upload file page

Clicking at the Upload File button in the MAIN page, the program will ask you to upload an .ast file from your PC.

### Table page

![Captura de pantalla 2022-12-07 095144](https://user-images.githubusercontent.com/114604246/206154332-2d6b71bd-e974-4bc3-82ae-955d4bc01671.jpg)

On this page, you will be able to see the main information in the table. This information are: the Category, the position in the global list, the position in the category list, the time in seconds, the latitude, the longitude, the SIC, the SAC, the Track number, the target ID and the Flight level. Then, to see the rest of the information, you have to click on the table the row of the object you want to see and the other information will appear next to the table. This information will be classified into four pages: Navigation, Identification, ADSB and Miscelaneous. To change between this pages, you have to click the Next Page/Previous Page buttons. Also, you can order the list by categories or leave it by the order of appearance in the asterix file. Finally, you can search for whatever you want in the table by entering the name of the object you are looking for and entering the name of the table column where you want to search.  

### MAP page

![Captura de pantalla 2022-12-07 095218](https://user-images.githubusercontent.com/114604246/206158689-f43aa12f-d0ed-4fe8-81cc-b13766f7274c.jpg)

On this page, you will be able to simulate the position of what the diferents systems detects. For the SMR will appear a black marker, for the MLAT a blue one and for the ADSB a yellow one. To start the simulation you have to click the play button that turn into the pause button when the simulation is running. To reset the simulation click on the RESET button. If you want to change the initial time, you can change it introducing the hour:minutes:seconds into the diferent list that are below the reset button and the clicking the accept button. If you want to see the information of one marker, you have to click on it and then the main information will appear on the table that is below the map. Finally, you can change the configuration of the simulation clicking in the configuration button.

### Configuration page

![Captura de pantalla 2022-12-07 095547](https://user-images.githubusercontent.com/114604246/206162615-86eba79e-ddc7-4cf2-9899-a7e3f14ada9d.jpg)

On this page you can change the velocity of the simulaion (x1, x2, x5, x10, x20), you can select which type of category do you want to see, you can change the map view (satellite map, original map, relief map) and you can select if you want to see the old markers or not. When you have changed your configuration, you have to click the accept button to save the changes.
