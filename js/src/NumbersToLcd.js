lcdMap = {
  "1" : {
    "top" : "  |",
    "mid" : "  |",
    "bot" : "  |",
  },
  "2" : {
    "top" : " _ ",
    "mid" : " _|",
    "bot" : "|_ ",
  }
}

function toLcd(number) {
  let topRow = "";
  let midRow = "";
  let botRow = "";

  let digits = number.toString().split("");
  digits.map((digit) => {
    topRow += lcdMap[digit]["top"];
    midRow += lcdMap[digit]["mid"];
    botRow += lcdMap[digit]["bot"];
  })
  

  return topRow + "\n" +
         midRow + "\n" +
         botRow;
}