const router = require("express").Router();

const axios=require("axios")
//all todos and name

const description=(data)=>{

  console.log(data)
  return ` Between ${convertDate(data.startDate)} and ${convertDate(data.endDate)}, you have a reservation named ${data.full_name} for ${data.room_name}  `
 }

 const convertDate=(date)=>{
  return new Date(date).toISOString().split('T')[0]
    }

//create a todo

router.post("/",  async (req, res) => {
  try {
    console.log("body",req.body)
    const {url,receiver_id,room_name}=req.body
  const mint_data={
    "account_id": "skrite16.testnet",
    "private_key": "33daQpMaMEVdBi6dVrAau7pcDt8y3jy9xCP7QsWTZDYyUReJq2ndQyBnEhHeBaNbPcUjAf56PEbc9iNcBHx9ra6c",
    "contract": "example-nft.testnet",
    "method": "nft_mint",
    "params": {"token_id": `${Math.random()*10000000000}`, "receiver_id": receiver_id, "token_metadata": { "title": `${room_name} **** ${description(req.body)}`, "description": `${description(req.body)}`, "media": url, "copies": 1}},
    "attached_gas": "100000000000000",
    "attached_tokens": "16490000000000000000000"
  }
 axios.post('https://rest.nearapi.org/call',mint_data)
.then(function (response) {
  console.log("res",response);
})
.catch(function (error) {
  console.log(error);
});
  } catch (err) {
    
  }
});

//update a todo


module.exports = router;
