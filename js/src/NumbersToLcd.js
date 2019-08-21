lcdMap = {
  1 : {
    "top" : "  |",
    "mid" : "  |",
    "bot" : "  |",
  },
  2 : {
    "top" : " _ ",
    "mid" : " _|",
    "bot" : "|_ ",
  }
}

function toLcd(number) {
  var topRow, midRow, botRow;

  topRow = lcdMap[number]["top"];
  midRow = lcdMap[number]["mid"];
  botRow = lcdMap[number]["bot"];

  return topRow + "\n" +
         midRow + "\n" +
         botRow;
}