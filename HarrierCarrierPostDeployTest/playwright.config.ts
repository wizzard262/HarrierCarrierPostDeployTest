import { defineConfig } from '@playwright/test';

// This enables an HTML report output
export default defineConfig({
  reporter: [['html', { outputFolder: 'playwright-report' }]],
});
