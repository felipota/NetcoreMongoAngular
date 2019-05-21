import { TestBed } from '@angular/core/testing';

import { SClienteResetService } from './scliente-reset.service';

describe('SClienteResetService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SClienteResetService = TestBed.get(SClienteResetService);
    expect(service).toBeTruthy();
  });
});
