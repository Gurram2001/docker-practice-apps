import express from 'express';
const app = express();
app.get('/', (_req, res) => res.send('Hello from TypeScript Express!'));
app.listen(3000, () => console.log('Server running on port 3000'));
