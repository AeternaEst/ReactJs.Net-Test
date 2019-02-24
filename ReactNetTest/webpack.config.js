module.exports = {
  mode: 'development',
  entry: ['./Frontend/src/helloworld.jsx', './Frontend/src/entrypoint.jsx'],
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
    filename: 'bundle.js'
  }
};