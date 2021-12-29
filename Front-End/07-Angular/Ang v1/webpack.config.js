const path = require("path");
module.exports = {
  // here start of webpack for reading files
  entry: "./src/index.js",
  // here where is the output of those files to gathering them
  output: {
    filename: "bundle.js",
    path: path.resolve(__dirname, "./dist"),
  },
  mode: "none",
};
