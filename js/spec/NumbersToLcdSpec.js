describe("NumbersToLcd", function() {

  it("should display 1 as lcd", function() {
    var lcdNumber = toLcd(1)

    expect(lcdNumber).toEqual("  |" + "\n" +
                              "  |" + "\n" +
                              "  |");
  });

});
