const path = require("path");
const webpack = require("webpack");
const ExtractTextPlugin = require("extract-text-webpack-plugin");
const CheckerPlugin = require("awesome-typescript-loader").CheckerPlugin;
const CopyWebpackPlugin = require("copy-webpack-plugin");
const bundleOutputDir = "./wwwroot/dist";

const extractLESS = new ExtractTextPlugin("stylesheets/[name].css");

module.exports = env => {
  const isDevBuild = !(env && env.prod);

  return [
    {
      stats: { modules: false },
      context: __dirname,
      resolve: {
        extensions: [".js", ".ts"],
        alias: {
          vue: "vue/dist/vue.js"
        }
      },
      entry: { main: "./ClientApp/boot.js" },
      module: {
        rules: [
          {
            test: /\.vue\.html$/,
            include: /ClientApp/,
            use: {
              loader: "vue-loader",
              options: {
                loaders: {
                  js: {
                    loader: "awesome-typescript-loader",
                    options: { silent: true }
                  }
                }
              }
            }
          },
          {
            test: /\.ts$/,
            include: /ClientApp/,
            use: [
              {
                loader: "awesome-typescript-loader",
                options: { silent: true }
              }
            ]
          },
          {
            test: /\.css$/,
            use: isDevBuild
              ? ["style-loader", "css-loader"]
              : ExtractTextPlugin.extract({
                  use: { loader: "css-loader", options: { minimize: true } }
                })
          },
          {
            test: /\.less$/,
            loader: ExtractTextPlugin.extract(
              "css-loader?sourceMap!less-loader"
            )
          },
          // {
          //   test: /\.less$/,
          //   use: extractLESS.extract(["css-loader", "less-loader"])
          // },
          {
            test: /.(ttf|otf|eot|svg|woff(2)?)(\?[a-z0-9]+)?$/,
            use: {
              loader: "file-loader",
              options: {
                name: "fonts/[name].[ext]" //outputPath: "fonts/"
              }
            }
          },
          {
            test: /\.(png|jpg|jpeg|gif|svg)$/,
            use: {
              loader: "file-loader",
              options: { name: "[name].[ext]" }
            }
          },
          {
            test: /\.ico$/,
            use: {
              loader: "file-loader",
              options: { name: "[name].[ext]" }
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
        // new CopyWebpackPlugin([
        //   { from: "./Images/listings", to: "images/listings" }
        // ]),
        //extractLESS,
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
