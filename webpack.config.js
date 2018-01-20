const path = require("path");
const webpack = require("webpack");
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const CheckerPlugin = require("awesome-typescript-loader").CheckerPlugin;
const bundleOutputDir = "./wwwroot/dist";

module.exports = env => {
  const isDevBuild = !(env && env.prod);

  return [
    {
      stats: { modules: false },
      context: __dirname,
      resolve: { extensions: [".js", ".ts"] },
      entry: { main: "./ClientApp/boot.js" },
      module: {
        rules: [
          {
            test: /\.vue\.html$/,
            include: /ClientApp/,
            loader: "vue-loader",
            options: {
              loaders: { js: "awesome-typescript-loader?silent=true" }
            }
          },
          {
            test: /\.ts$/,
            include: /ClientApp/,
            use: "awesome-typescript-loader?silent=true"
          },
          {
            test: /\.css$/,
            use: isDevBuild
              ? ["style-loader", "css-loader"]
              : ExtractTextPlugin.extract({ use: "css-loader?minimize" })
          },
          {
            test: /\.(png|jpg|jpeg|gif|svg)$/,
            use: {
              loader: "url-loader",
              options: { limit: 8000, name: "[name].[ext]" }
            }
          },
          {
            test: /\.ico$/,
            use: {
              loader: "file-loader",
              options: { name: "[name].[ext]" }
            }
          },
          {
            test: /.(ttf|otf|eot|svg|woff(2)?)(\?[a-z0-9]+)?$/,
            use: {
              loader: "file-loader",
              options: {
                name: "[name].[ext]",
                outputPath: "fonts/"
              }
            }
          }
        ]
      },
      output: {
        path: path.join(__dirname, bundleOutputDir),
        filename: "[name].js",
        publicPath: "dist/"
      },
      plugins: [
        new CheckerPlugin(),
        new webpack.DefinePlugin({
          "process.env": {
            NODE_ENV: JSON.stringify(isDevBuild ? "development" : "production")
          }
        }),
        new webpack.DllReferencePlugin({
          context: __dirname,
          manifest: require("./wwwroot/dist/vendor-manifest.json")
        })
      ].concat(
        isDevBuild
          ? [
              // Plugins that apply in development builds only
              new webpack.SourceMapDevToolPlugin({
                filename: "[file].map", // Remove this line if you prefer inline source maps
                moduleFilenameTemplate: path.relative(
                  bundleOutputDir,
                  "[resourcePath]"
                ) // Point sourcemap entries to the original file locations on disk
              })
            ]
          : [
              // Plugins that apply in production builds only
              new webpack.optimize.UglifyJsPlugin(),
              new ExtractTextPlugin("site.css")
            ]
      )
    }
  ];
};
