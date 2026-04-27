import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IntencionPagoComponent } from './intencion-pago.component';

describe('IntencionPagoComponent', () => {
  let component: IntencionPagoComponent;
  let fixture: ComponentFixture<IntencionPagoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [IntencionPagoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(IntencionPagoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
