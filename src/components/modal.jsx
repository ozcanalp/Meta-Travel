import * as React from 'react';
import Box from '@mui/material/Box';
import Modal from '@mui/material/Modal';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import CloseIcon from '@mui/icons-material/Close';
const style = {
  position: 'absolute',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: 400,
  bgcolor: 'background.paper',
  border: '2px solid #000',
  boxShadow: 24,
  p: 4,
};

export default function KeepMountedModal({open,signIn,setOpen}) {
console.log(open)

  return (
    <div className='relative'>
      
      <Modal
       keepMounted
        open={open}
      
        aria-labelledby="keep-mounted-modal-title"
        aria-describedby="keep-mounted-modal-description"
      >
        <Box sx={style}>
          <Typography id="keep-mounted-modal-title" variant="h6" component="h2">
            Connect Wallet
          </Typography>
          <Typography id="keep-mounted-modal-description" sx={{ mt: 2 }}>
          You must connect a Wallet to continue. 
          </Typography>
          <Button className="mtb-1" onClick={signIn} variant="contained" color="primary" >
                 Connect Near Wallet
                </Button>

                <CloseIcon className="close-icon" onClick={()=>setOpen(false)} />
             
        </Box>
      </Modal>
    </div>
  );
}