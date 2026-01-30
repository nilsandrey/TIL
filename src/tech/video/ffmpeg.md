# FFMPEG tool tips

## Screen recording, respecting much text info:

```bash
ffmpeg -i "input.mp4" -c:v libx264 -preset slow -crf 20 -tune ssim -c:a aac -b:a 128k "output.mp4"
```
