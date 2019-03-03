import { ValidatorFn, Validator, AbstractControl, NG_VALIDATORS, FormControl } from '@angular/forms';
import { Directive, Input } from '@angular/core';

@Directive({
  // tslint:disable-next-line:directive-selector
  selector: '[maxValue][ngModel]',
  providers: [
    { provide: NG_VALIDATORS, useExisting: MaxValueValidatorDirective, multi: true }
  ]
})
export class MaxValueValidatorDirective implements Validator {
  @Input()
  maxValue: number;

  validate(c: FormControl) {
    return (c.value > this.maxValue) ? {'maxValue': true} : null;
  }
}
