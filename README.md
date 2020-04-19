# nhk-easy [![CircleCI](https://circleci.com/gh/Frederick-S/nhk-easy.svg?style=shield)](https://circleci.com/gh/Frederick-S/nhk-easy) [![Build status](https://ci.appveyor.com/api/projects/status/fdufga28cyy4srb0/branch/master?svg=true)](https://ci.appveyor.com/project/Frederick-S/nhk-easy/branch/master)
Download audios from [NHK NEWS WEB EASY](https://www3.nhk.or.jp/news/easy/).

## Installation
1. Install [FFmpeg](https://www.ffmpeg.org/) and add it to path
2. `dotnet tool install --global NHKEasy`

## Usage
```
nhk-easy k10011658401000 // "k10011658401000" is the id of a page, you can find it in page url
```

## License
MIT
