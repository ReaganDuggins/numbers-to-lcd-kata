describe("NumbersToLcd", function() {

  it("should display 1 as lcd", function() {
    var lcdNumber = toLcd(1)

    expect(lcdNumber).toEqual("  |" + "\n" +
                              "  |" + "\n" +
                              "  |");
  });

  it("should display 2 as lcd", function() {
    var lcdNumber = toLcd(2)

    expect(lcdNumber).toEqual(" _ " + "\n" +
                              " _|" + "\n" +
                              "|_ ");
  });

});
