import { TestBed } from '@angular/core/testing';

import { SClienteService } from './scliente.service';

describe('SClienteService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SClienteService = TestBed.get(SClienteService);
    expect(service).toBeTruthy();
  });
});
