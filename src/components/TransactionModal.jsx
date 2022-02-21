import * as React from "react";
import Box from "@mui/material/Box";
import Modal from "@mui/material/Modal";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import CheckCircleOutlineIcon from '@mui/icons-material/CheckCircleOutline';
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link,
  Redirect,
} from "react-router-dom";
const style = {
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  width: 400,
  bgcolor: "background.paper",
  border: "2px solid #000",
  boxShadow: 24,
  p: 4,
};

export default function ModalT({ open, transaction, setOpen }) {
  console.log(transaction);
  var { hash, signature, receiver_id, signer_id } = transaction;
  return (
    <div>
      <Modal
        keepMounted
        open={open}
        aria-labelledby="keep-mounted-modal-title"
        aria-describedby="keep-mounted-modal-description"
      >
        <Box sx={style} className="center-column">
         <CheckCircleOutlineIcon className="check-icon"/>
          <a href={`https://explorer.testnet.near.org/transactions/${hash}`}>
            Click to explore Transaction
          </a>
          <h3 className="truncate">signature : {signature && signature}</h3>
          <h3 className="truncate">receiver : {receiver_id && receiver_id}</h3>
          <h3 className="truncate">signer : {signer_id && signer_id}</h3>
          <Link to="profile">
          <Button
            className="mtb-1"
            
            variant="contained"
            color="primary"
          >
           my bookings
          </Button>
          </Link>
        </Box>
      </Modal>
    </div>
  );
}
