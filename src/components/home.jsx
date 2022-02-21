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
import deluxe from "../assets/roomImages/2.jpg"
import master from "../assets/roomImages/0.jpg"
import superior from "../assets/roomImages/1.jpg"

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
image:deluxe,name:"Deluxe Room",city:"Antalya",id:2

},{
    image:master,name:"Master Room",city:"Antalya",id:0
    
    },{
        image:superior,name:"Superior Room",city:"Antalya",id:1
        
        }];

const theme = createTheme();

export default function Album() {
  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
      
      <main>
        {/* Hero unit */}
       
          <Container maxWidth="md">
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
            A new generation hotel reservation system powered by Near Protocol.

            </Typography>
          <div className="nearContainer"> <img style={{width:"30%",alignSelf:"center"}} src="/near_logo.png"></img></div>
       
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
        <Container maxWidth="md">
          <Typography className="mt-1_" variant="h5" align="center" color="text.secondary" paragraph>
            By making hotel reservations with the Near Protocol infrastructure, you will protect your reservation at the maximum level.

            </Typography>
            <Typography variant="h5" align="center" color="text.secondary" paragraph>
         
If you are undecided about choosing a hotel room or if you are looking for a new experience, you can take a virtual tour of the hotel rooms on the web.

              </Typography>
              </Container>
      </main>
      {/* Footer */}
      <Box sx={{ bgcolor: 'background.paper', p: 6 }} component="footer">
       
        <Typography
          variant="subtitle1"
          align="center"
          color="text.secondary"
          component="p"
        >
         METATRAVEL
        </Typography>
      
      </Box>
      {/* End footer */}
    </ThemeProvider>
  );
}