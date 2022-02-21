const express = require("express");
const app = express();
const cors = require("cors");
const PORT = process.env.PORT || 3000;
//middleware

app.use(cors());
app.use(express.json());

//routes
app.use(function(req, res, next) {
  res.header("Access-Control-Allow-Origin", "YOUR-DOMAIN.TLD"); // update to match the domain you will make the request from
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  next();
});


app.use("/mint_nft", require("./routes/nft"));

app.listen(PORT, () => {

  console.log(`Server is starting on port 5000`);
});
