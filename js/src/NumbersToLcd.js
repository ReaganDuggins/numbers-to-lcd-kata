function toLcd(number) {
  var topRow = "  |";
  var midRow = "  |";
  var botRow = "  |";

  if (number === 2) {
    topRow = " _ ";
    midRow = " _|";
    botRow = "|_ ";
  }

  return topRow + "\n" +
         midRow + "\n" +
         botRow;
}