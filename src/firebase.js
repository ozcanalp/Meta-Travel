// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
import { getFirestore } from "firebase/firestore"
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyA-3lAp6DYG11F6C23otWlVRYs_50QPbjg",
  authDomain: "metatravel-d0f1d.firebaseapp.com",
  projectId: "metatravel-d0f1d",
  storageBucket: "metatravel-d0f1d.appspot.com",
  messagingSenderId: "557599997669",
  appId: "1:557599997669:web:28baf31238c9eb43cede0c",
  measurementId: "G-LR27J1FVSN"
};

// Initialize Firebase
export const app = initializeApp(firebaseConfig);
export const db = getFirestore(app);
