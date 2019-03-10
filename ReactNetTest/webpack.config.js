const path = require('path');

module.exports = {
  mode: 'development',
  entry: {
        server: ['./Frontend/src/expose-components.js'],
		client: ['./Frontend/src/client.jsx']
    },
  module: {
    rules: [
      {
        test: /\.(js|jsx)$/,
        exclude: /node_modules/,
        use: ['babel-loader']
      }
    ]
  },
  resolve: {
    extensions: ['*', '.js', '.jsx']
  },
  output: {
    path: __dirname + '/Frontend/dist',
    publicPath: '/',
    filename: '[name].bundle.js'
  }
};