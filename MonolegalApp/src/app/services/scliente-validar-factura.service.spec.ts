import { TestBed } from '@angular/core/testing';

import { SClienteValidarFacturaService } from './scliente-validar-factura.service';

describe('SClienteValidarFacturaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SClienteValidarFacturaService = TestBed.get(SClienteValidarFacturaService);
    expect(service).toBeTruthy();
  });
});
