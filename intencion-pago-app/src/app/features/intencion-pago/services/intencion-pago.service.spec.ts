import { TestBed } from '@angular/core/testing';

import { IntencionPagoService } from './intencion-pago.service';

describe('IntencionPagoService', () => {
  let service: IntencionPagoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IntencionPagoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
