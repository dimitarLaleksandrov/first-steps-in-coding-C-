const path = require('path');
const CopyPlugin = require('copy-webpack-plugin');

module.exports = {
  entry: {
		main: [
			'@babel/polyfill',
			'./src/index.js',
		]
	},
  output: {
    filename: 'app.js',
    path: path.resolve(__dirname, 'dist'),
  },
  module: {
    rules: [
      {
        test: /\.m?js$/,
        exclude: /(node_modules|bower_component)/,
        use: {
          loader: 'babel-loader',
          options: {
            presets: ['@babel/preset-env'],
            plugins: [
              '@babel/plugin-transform-runtime',
              '@babel/plugin-transform-dotall-regex'
            ]
          }
        }
      }
    ]
  },
  plugins: [
    new CopyPlugin([
      { from: './src/index.html', to: 'index.html' },
      { from: './src/views', to: 'views' },
      { from: './src/static', to: 'static' }
    ]),
  ],
  devServer: {
    compress: true,
    port: 9000,
    historyApiFallback: true
  }
};