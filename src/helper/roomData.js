import deluxe from "../assets/roomImages/deluxe-suit.png";
import master from "../assets/roomImages/master-suit.png";
import superior from "../assets/roomImages/superior-room.png";
const roomData = [
  {
    images: [
      {
        original: master,
        thumbnail: master,
      },
    ],
    name: "master suit room",
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
    name: "superior room",
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
    name: "deluxe suit room",
    city: "Antalya",
    roomId: 2,
  },
  
];

export default roomData;
