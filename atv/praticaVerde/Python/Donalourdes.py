def main():
    r = 0
    n = 0
    s = 998
    while r != 999:
        r = float(input())
        if r > n and r != 999:
            n = r
        if r < s:
            s = r
    print(f"{n:.2f} {s:.2f}")

if __name__ == "__main__":
    main()
