import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Button from '@mui/material/Button';
import CameraIcon from '@mui/icons-material/PhotoCamera';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import CssBaseline from '@mui/material/CssBaseline';
import Grid from '@mui/material/Grid';
import Stack from '@mui/material/Stack';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import HomeCard from "./homePageCard"
import Container from '@mui/material/Container';
import {
  
  Link

} from "react-router-dom";
import deluxe from "../assets/roomImages/deluxe-suit.png"
import master from "../assets/roomImages/master-suit.png"
import superior from "../assets/roomImages/superior-room.png"

import { createTheme, ThemeProvider } from '@mui/material/styles';

function Copyright() {
  return (
    <Typography variant="body2" color="text.secondary" align="center">
      {'Copyright © '}
      <Link color="inherit" href="https://mui.com/">
        Your Website
      </Link>{' '}
      {new Date().getFullYear()}
      {'.'}
    </Typography>
  );
}

const cards = [{
image:deluxe,name:"deluxe room",city:"Antalya",id:2

},{
    image:master,name:"master room",city:"Antalya",id:0
    
    },{
        image:superior,name:"superior room",city:"Antalya",id:1
        
        }];

const theme = createTheme();

export default function Album() {
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      
      <main>
        {/* Hero unit */}
       
          <Container maxWidth="sm">
            <Typography
              component="h1"
              variant="h2"
              align="center"
              color="text.primary"
              gutterBottom
            >
             <span style={{color:"#1976d2"}}> META</span>TRAVEL
            </Typography>
            <Typography variant="h5" align="center" color="text.secondary" paragraph>
            Metaverse where you can buy nft and book rooms 
            </Typography>
            <Stack
              sx={{ pt: 4 }}
              direction="row"
              spacing={2}
              justifyContent="center"
            >
           
              <Link to="/tour-hotel"><Button variant="outlined">Tour THE HOTEL</Button></Link>
            </Stack>
          </Container>
      
        
        <Container sx={{ py: 8 }} maxWidth="lg">
          {/* End hero unit */}
          <Grid container spacing={4}>
            {cards.map((card) => (
              <Grid item key={card} xs={12} sm={6} md={4}>
                <HomeCard data={card}></HomeCard>
              </Grid>
            ))}
          </Grid>
        </Container>

      </main>
      {/* Footer */}
      <Box sx={{ bgcolor: 'background.paper', p: 6 }} component="footer">
        <Typography variant="h6" align="center" gutterBottom>
          Footer
        </Typography>
        <Typography
          variant="subtitle1"
          align="center"
          color="text.secondary"
          component="p"
        >
         Metatravel
        </Typography>
      
      </Box>
      {/* End footer */}
    </ThemeProvider>
  );
}