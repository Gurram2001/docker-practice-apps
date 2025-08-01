use std::fs;
fn main() {
    let data = fs::read_to_string("sample.txt").expect("Unable to read file");
    println!("File contents: {}", data);
}
