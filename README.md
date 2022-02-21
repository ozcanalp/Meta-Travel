
## Inspiration
Nowadays, with the increasing digitalization, various technical problems can be experienced. A few of our team members had problems with various reservations they made. For example, 'Erinc' once went to the hotel that he had made a reservation for, and said that the hotel reservation was not made. Emre also experienced another unpleasant problem in the car reservation. Since the data transfer here is collected in a single center, it is very difficult to prove that the transactions are done. We developed our plan to make reservations through a **decentralized** and **sustainable** technology, thanks to the **Near Protocol** infrastructure.
## What it does
Within the scope of this project, our aim is to be able to navigate the hotels in a **3D metaverse environment** with a near-realistic experience and to make reservation **transactions over the Near blockchain**. As you can see in the demo video, the person visits the rooms of a sample hotel in a 3D environment and comes to the reception to complete the reservation process for the room they liked.The reservation process starts by connecting the Near wallet. According to the selected preferences, an **NFT** version of the room will be sent to the user's Near wallet along with the reservation information.

In this way, when the customers go to the hotel they have booked, they will know that the reservation has been made for sure, and they will not experience an unpleasant surprise in the room they will go to. In addition to these, there will be a souvenir NFT related to the reservation made.
## How we built it
Our project consists of three main areas;
 - **Blockchain** 
		 - We preferred Near Protocol, which is a sustainable and bright future technology in the field of Blockchain - NFT.
		 - we connected our application with the Near wallet by using **NEAR-API-JS** on the client-side. Then, we signed the booking process with transactions by taking advantage of the opportunities that Near wallet gave us. We distributed the booking NFTs, which we mint on the server side dynamically, to the wallet that made the booking after the transaction.

 - **Web**
		 - In order for the application to interact with users, we developed it in the web environment.
		 - We used the open source React library for ease of use and dynamism. We have made various changes in order to run **WebGL** applications. In addition, we have connected the Near Wallet system to our site.

 - **3D Virtual Environment**
		 - In order to provide our users with a unique experience as well as reliability, we have done a 3D environment design on WebGL.
		 - We developed our WebGL side of the website with Unity. First, we create First Person camera mechanics of the project then we add multiplayer features. We add an object interaction feature, to give the user ability to not just walk around also interact with the environment. Users can travel inside the hotel to decide which room they gonna choose. That's why we add computer on the reception desk for booking room feature.

## Challenges we ran into

 - There were some problems in the "mint_nft" endpoint in the javascript API of Near, it was returning an error even though all the parameters were correct, thanks to the **Near University** Discord channel, we solved this problem with the "call" endpoint of Near API
 - It was challenging to separate the UI of the Player game object, which avatar of the users. Every Player of users has a different UI canvas, on the other hand, the system cannot differentiate the canvases cause it seems like there is only one canvas in the system.
 - We wanted to make our application usable even on low-end devices. The goal is to make sure that more people can use it without performance issues. Good optimization is the key to that goal. However, it is a big challenge as well. We had to adjust every 3D model, light, and texture carefully.
## Accomplishments that we're proud of
 - In the Near ecosystem, we have used almost all of the basic functions such as wallet binding, wallet deletion, transaction creation, **NFT minting**.
 - We developed the mechanics as realistic as possible like walking around in the hotel area, booking the hotel rooms from reception. Also, you don't have to do it alone because we developed the project with a multiplayer feature.
 - We optimized our application well. It works without any performance issues.

## What we learned

 - We learned how transactions are made in the Near ecosystem, the blockchain logic, the non-fungible token logic, and how it is implemented, and we have used it in our project. It was a significant advance for us on Web3.
 - We learn to develop a game with a First Person camera and make this First Person camera mechanics multiplayer.
 - We need to have optimization in our minds all the time. Even while deciding something small because otherwise, those small things turn into big problems.

## What's next for MetaTravel
We think that people in the tourism sector will be able to make decisions and make reservations more easily by experiencing the facilities of the hotel in a 3D environment.

In fact, we plan to shorten hotel check-in times with our digital-id infrastructure , which we will develop based on near blockchain.For this, customers will be able to perform passport digital onboarding processes before coming to the hotel via the **identity mobile wallet**. In this way, customers will be able to scan their passports with their digital identity wallets before arriving at the hotel, and check-in only by scanning a **QR code** while entering the hotel.

In this project, 2D and 3D Artists will be able to create their unique NFT artworks on Near, hold an event and they will exhibit and sell all their **NFT artworks** in the **MetaTravel’s Hotels NFT Showrooms**. Our audience will be everyone who is interested in art or **VR technology**. No need to be a blockchain expert. No need to be a VR tech expert. Simplicity and seamless experience are the key points of our VR NFT Gallery’s value proposition. We made an [VR NFT Gallery showroom as a MVP](https://www.youtube.com/watch?v=FJ6cEDNDV4o).
