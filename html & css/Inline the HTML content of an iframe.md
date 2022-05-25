# Inline the HTML content of an iframe

You can use iframe element's attributes alternatively:

- `srcdoc`: Directly the HTML content of the page to embed
- `src`: Is the URL of the page to embed but you can use

```html
<iframe srcdoc="<p>Hello world</p>"></iframe>
```

```html
<iframe src="data:text/html;charset=utf-8,<p>Hello world</p>"></iframe>
```

```js
var iframe = document.createElement("iframe");
iframe.srcdoc = `<!DOCTYPE html><p>Hello World!</p>`;
document.body.appendChild(iframe);
```

## Rerefences

- [What is the difference between srcdoc="..." and src="data:text/html,..." in an iframe?](https://stackoverflow.com/questions/19739001/what-is-the-difference-between-srcdoc-and-src-datatext-html-in-an)
- [HTMLIFrameElement.srcdoc](https://developer.mozilla.org/en-US/docs/Web/API/HTMLIFrameElement/srcdoc)
