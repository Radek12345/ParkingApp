import { ValidatorFn, Validator, AbstractControl, NG_VALIDATORS, FormControl } from '@angular/forms';
import { Directive, Input } from '@angular/core';

@Directive({
  // tslint:disable-next-line:directive-selector
  selector: '[minValue][ngModel]',
  providers: [
    { provide: NG_VALIDATORS, useExisting: MinValueValidatorDirective, multi: true }
  ]
})
export class MinValueValidatorDirective implements Validator {
  @Input()
  minValue: number;

  validate(c: FormControl) {
    return (c.value < this.minValue) ? {'minValue': true} : null;
  }
}
