import deluxe from "../assets/roomImages/2.jpg"
import master from "../assets/roomImages/0.jpg"
import superior from "../assets/roomImages/1.jpg"

const roomData = [
  {
    images: [
      {
        original: master,
        thumbnail: master,
      },
    ],
    name: "Master Suit Room",
    city: "Antalya",
    roomId: 0,
  },
  {
    images: [
      {
        original: superior,
        thumbnail: superior,
      },
    ],
    name: "Superior room",
    city: "Antalya",
    roomId: 1,
  },
  {
    images: [
      {
        original: deluxe,
        thumbnail: deluxe,
      },
    ],
    name: "Deluxe Suit Room",
    city: "Antalya",
    roomId: 2,
  },
  
];

export default roomData;
