# Query selector and HTMLElement interface

This hack is needed:

```typescript
const el = document.querySelectorAll(
      'mat-radio-group label.mat-radio-label'
    );
    if (el)
      el.forEach(e => {
        (e as HTMLElement).style.display = 'flex';
        (e as HTMLElement).style.flexDirection = 'column';
      });
```

