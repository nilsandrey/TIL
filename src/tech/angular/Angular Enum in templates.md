# Angular Enum in templates

https://twitter.com/nilsandrey/status/1155482101564747776?s=20 

```typescript
import { Component } from '@angular/core'; 
 
enum LanguageType {Java = 1, 'JavaScript' = 2, "TypeScript" = 3} 
 
@Component({ 
  selector: 'my-app', 
  templateUrl: './app.component.html', 
  styleUrls: [ './app.component.css' ] 
}) 
export class AppComponent  { 
  languageTypeDeclaredInComponent = LanguageType; 
 
constructor() { 
  // this works 
  console.log("Language Java", LanguageType.Java); 
  // this works 
  console.log("Language JavaScript", this.languageTypeDeclaredInComponent.JavaScript) 
  } 
} 
```
