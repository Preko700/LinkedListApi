const express = require('express');
const cors = require('cors');
const LinkedList = require('./linkedList');

const app = express();
const PORT = process.env.PORT || 3000;

// Middleware
app.use(cors());
app.use(express.json());

// Create a singleton instance of LinkedList (persists in memory)
const linkedList = new LinkedList();

// GET /linked-list/ - Return the current state of the list
app.get('/linked-list/', (req, res) => {
  const list = linkedList.toList();
  res.json(list);
});

// POST /linked-list/ - Add a new element to the list
app.post('/linked-list/', (req, res) => {
  const { value } = req.body;
  
  if (!value) {
    return res.status(400).json({ error: 'Value is required' });
  }

  const node = linkedList.add(value);
  res.status(201).json({ id: node.id });
});

// DELETE /linked-list/:id - Delete an element by ID
app.delete('/linked-list/:id', (req, res) => {
  const { id } = req.params;
  
  const result = linkedList.remove(id);
  if (!result) {
    return res.status(404).json({ error: 'Node not found' });
  }
  
  res.status(204).send();
});

// Start the server
app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});